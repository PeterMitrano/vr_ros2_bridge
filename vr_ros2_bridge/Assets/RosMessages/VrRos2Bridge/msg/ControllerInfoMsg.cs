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
        public bool trigger_button;
        public bool grip_button;
        public bool trackpad_button;
        public float trigger_axis;

        public ControllerInfoMsg()
        {
            this.controller_name = "";
            this.controller_pose = new Geometry.PoseMsg();
            this.trigger_button = false;
            this.grip_button = false;
            this.trackpad_button = false;
            this.trigger_axis = 0.0f;
        }

        public ControllerInfoMsg(string controller_name, Geometry.PoseMsg controller_pose, bool trigger_button, bool grip_button, bool trackpad_button, float trigger_axis)
        {
            this.controller_name = controller_name;
            this.controller_pose = controller_pose;
            this.trigger_button = trigger_button;
            this.grip_button = grip_button;
            this.trackpad_button = trackpad_button;
            this.trigger_axis = trigger_axis;
        }

        public static ControllerInfoMsg Deserialize(MessageDeserializer deserializer) => new ControllerInfoMsg(deserializer);

        private ControllerInfoMsg(MessageDeserializer deserializer)
        {
            deserializer.Read(out this.controller_name);
            this.controller_pose = Geometry.PoseMsg.Deserialize(deserializer);
            deserializer.Read(out this.trigger_button);
            deserializer.Read(out this.grip_button);
            deserializer.Read(out this.trackpad_button);
            deserializer.Read(out this.trigger_axis);
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.controller_name);
            serializer.Write(this.controller_pose);
            serializer.Write(this.trigger_button);
            serializer.Write(this.grip_button);
            serializer.Write(this.trackpad_button);
            serializer.Write(this.trigger_axis);
        }

        public override string ToString()
        {
            return "ControllerInfoMsg: " +
            "\ncontroller_name: " + controller_name.ToString() +
            "\ncontroller_pose: " + controller_pose.ToString() +
            "\ntrigger_button: " + trigger_button.ToString() +
            "\ngrip_button: " + grip_button.ToString() +
            "\ntrackpad_button: " + trackpad_button.ToString() +
            "\ntrigger_axis: " + trigger_axis.ToString();
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
