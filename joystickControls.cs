using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityStandardAssets.CrossPlatformInput
{
    public class Joystick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
    {
        public enum AxisOption
        {
            OnlyHorizontal, // Axis to use horizontal

        }

        public int MovementRange = 100;
        public AxisOption axesToUse = AxisOption.OnlyHorizontal; // The options for the axes that the we will use
        public string horizontalAxisName = "Horizontal"; // The name given to the horizontal axis for the cross platform input

        Vector3 m_StartPos;
        bool m_UseX; // Toggle for using the x axis
        CrossPlatformInputManager.VirtualAxis m_HorizontalVirtualAxis; // Reference to the joystick in the cross platform input

        void OnEnable()
        {
            CreateVirtualAxes();
        }

        void Start()
        {
            m_StartPos = transform.position;
        }

        void UpdateVirtualAxes(Vector3 value)
        {
            var delta = m_StartPos - value;
            delta.y = -delta.y;
            delta /= MovementRange;
            if (m_UseX)
            {
                m_HorizontalVirtualAxis.Update(-delta.x);
            }

        }

        void CreateVirtualAxes()
        {
            m_UseX = (axesToUse == AxisOption.OnlyHorizontal);//create m_useX, new axes based on Horizontal axis
            if (m_UseX)
            {
                m_HorizontalVirtualAxis = new CrossPlatformInputManager.VirtualAxis(horizontalAxisName);
                CrossPlatformInputManager.RegisterVirtualAxis(m_HorizontalVirtualAxis);
            }
        }


        public void OnDrag(PointerEventData data)
        {
            Vector3 newPos = Vector3.zero;

            if (m_UseX)
            {
                int delta = (int)(data.position.x - m_StartPos.x);
                delta = Mathf.Clamp(delta, -MovementRange, MovementRange);
                newPos.x = delta;
            }

            transform.position = new Vector3(m_StartPos.x + newPos.x, m_StartPos.y + newPos.y, m_StartPos.z + newPos.z); // postion of axis 
            UpdateVirtualAxes(transform.position);
        }


        public void OnPointerUp(PointerEventData data)
        {
            transform.position = m_StartPos;
            UpdateVirtualAxes(m_StartPos);
        }


        public void OnPointerDown(PointerEventData data) { }

        void OnDisable()
        {
            // remove the joysticks from the cross platform input
            if (m_UseX)
            {
                m_HorizontalVirtualAxis.Remove();
            }

        }
    }
}