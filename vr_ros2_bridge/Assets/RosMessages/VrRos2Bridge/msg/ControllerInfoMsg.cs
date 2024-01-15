//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.VrRos2Bridge
{
    [Serializable]
    public class ControllerInfoMsg : Message
    {
        public const string k_RosMessageName = "vr_ros2_bridge_msgs/ControllerInfo";
        public override string RosMessageName => k_RosMessageName;

        public string controller_name;
        public Geometry.PoseMsg controller_pose;
        public Geometry.TwistMsg controller_velocity;
        public bool trigger_button;
        public bool grip_button;
        public bool trackpad_button;
        public bool menu_button;
        public bool primary_button;
        public bool secondary_button;
        public float trigger_axis;
        public float trackpad_axis_x;
        public float trackpad_axis_y;
        public float trackpad_axis_touch_x;
        public float trackpad_axis_touch_y;

        public ControllerInfoMsg()
        {
            this.controller_name = "";
            this.controller_pose = new Geometry.PoseMsg();
            this.controller_velocity = new Geometry.TwistMsg();
            this.trigger_button = false;
            this.grip_button = false;
            this.trackpad_button = false;
            this.menu_button = false;
            this.primary_button = false;
            this.secondary_button = false;
            this.trigger_axis = 0.0f;
            this.trackpad_axis_x = 0.0f;
            this.trackpad_axis_y = 0.0f;
            this.trackpad_axis_touch_x = 0.0f;
            this.trackpad_axis_touch_y = 0.0f;
        }

        public ControllerInfoMsg(string controller_name, Geometry.PoseMsg controller_pose, Geometry.TwistMsg controller_velocity, bool trigger_button, bool grip_button, bool trackpad_button, bool menu_button, bool primary_button, bool secondary_button, float trigger_axis, float trackpad_axis_x, float trackpad_axis_y, float trackpad_axis_touch_x, float trackpad_axis_touch_y)
        {
            this.controller_name = controller_name;
            this.controller_pose = controller_pose;
            this.controller_velocity = controller_velocity;
            this.trigger_button = trigger_button;
            this.grip_button = grip_button;
            this.trackpad_button = trackpad_button;
            this.menu_button = menu_button;
            this.primary_button = primary_button;
            this.secondary_button = secondary_button;
            this.trigger_axis = trigger_axis;
            this.trackpad_axis_x = trackpad_axis_x;
            this.trackpad_axis_y = trackpad_axis_y;
            this.trackpad_axis_touch_x = trackpad_axis_touch_x;
            this.trackpad_axis_touch_y = trackpad_axis_touch_y;
        }

        public static ControllerInfoMsg Deserialize(MessageDeserializer deserializer) => new ControllerInfoMsg(deserializer);

        private ControllerInfoMsg(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.controller_name);
            this.controller_pose = Geometry.PoseMsg.Deserialize(deserializer);
            this.controller_velocity = Geometry.TwistMsg.Deserialize(deserializer);
            deserializer.Read(out this.trigger_button);
            deserializer.Read(out this.grip_button);
            deserializer.Read(out this.trackpad_button);
            deserializer.Read(out this.menu_button);
            deserializer.Read(out this.primary_button);
            deserializer.Read(out this.secondary_button);
            deserializer.Read(out this.trigger_axis);
            deserializer.Read(out this.trackpad_axis_x);
            deserializer.Read(out this.trackpad_axis_y);
            deserializer.Read(out this.trackpad_axis_touch_x);
            deserializer.Read(out this.trackpad_axis_touch_y);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.controller_name);
            serializer.Write(this.controller_pose);
            serializer.Write(this.controller_velocity);
            serializer.Write(this.trigger_button);
            serializer.Write(this.grip_button);
            serializer.Write(this.trackpad_button);
            serializer.Write(this.menu_button);
            serializer.Write(this.primary_button);
            serializer.Write(this.secondary_button);
            serializer.Write(this.trigger_axis);
            serializer.Write(this.trackpad_axis_x);
            serializer.Write(this.trackpad_axis_y);
            serializer.Write(this.trackpad_axis_touch_x);
            serializer.Write(this.trackpad_axis_touch_y);
        }

        public override string ToString()
        {
            return "ControllerInfoMsg: " +
            "\ncontroller_name: " + controller_name.ToString() +
            "\ncontroller_pose: " + controller_pose.ToString() +
            "\ncontroller_velocity: " + controller_velocity.ToString() +
            "\ntrigger_button: " + trigger_button.ToString() +
            "\ngrip_button: " + grip_button.ToString() +
            "\ntrackpad_button: " + trackpad_button.ToString() +
            "\nmenu_button: " + menu_button.ToString() +
            "\nprimary_button: " + primary_button.ToString() +
            "\nsecondary_button: " + secondary_button.ToString() +
            "\ntrigger_axis: " + trigger_axis.ToString() +
            "\ntrackpad_axis_x: " + trackpad_axis_x.ToString() +
            "\ntrackpad_axis_y: " + trackpad_axis_y.ToString() +
            "\ntrackpad_axis_touch_x: " + trackpad_axis_touch_x.ToString() +
            "\ntrackpad_axis_touch_y: " + trackpad_axis_touch_y.ToString();
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}
