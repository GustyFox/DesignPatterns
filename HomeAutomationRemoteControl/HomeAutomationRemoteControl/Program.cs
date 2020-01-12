using HomeAutomationRemoteControl.Commands;
using HomeAutomationRemoteControl.VendorClasses;
using System;

namespace HomeAutomationRemoteControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Home Automation Remote Control!");

            RemoteControlWithUndo remoteControl = new RemoteControlWithUndo();

            Light livingRoomLight = new Light("Living Room");
            Light kitchenLight = new Light("Kitchen");
            GarageDoor garageDoor = new GarageDoor("Garage");
            CeilingFan ceilingFan = new CeilingFan("Living Room");
            Stereo stereo = new Stereo("Living Room");
            
            LightOnCommand livingRoomLightOn = new LightOnCommand(livingRoomLight);
            LightOffCommand livingRoomLightOff = new LightOffCommand(livingRoomLight);

            LightOnCommand kitchenLightOn = new LightOnCommand(kitchenLight);
            LightOffCommand kitchenLightOff = new LightOffCommand(kitchenLight);

            CeilingFanOnCommand celingFanOn = new CeilingFanOnCommand(ceilingFan);
            CeilingFanOffCommand celingFanOff = new CeilingFanOffCommand(ceilingFan);

            GarageDoorUpCommand garageOpen = new GarageDoorUpCommand(garageDoor);
            GarageDoorDownCommand garageClose = new GarageDoorDownCommand(garageDoor);

            StereoOnCommand stereoOn = new StereoOnCommand(stereo);
            StereoOffCommand stereOff = new StereoOffCommand(stereo);

            remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
            remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
            remoteControl.SetCommand(2, celingFanOn, celingFanOff);
            remoteControl.SetCommand(3, stereoOn, stereOff);

            Console.Write(remoteControl.toString());

            //Now Lets push some Buttons

            remoteControl.OnButtonWasPressed(0);
            remoteControl.OffButtonWasPressed(0);

            remoteControl.OnButtonWasPressed(1);
            remoteControl.OffButtonWasPressed(1);

            remoteControl.OnButtonWasPressed(2);
            remoteControl.OnButtonWasPressed(2);
            remoteControl.OnButtonWasPressed(2);
            remoteControl.OffButtonWasPressed(2);

            remoteControl.OnButtonWasPressed(3);
            remoteControl.OffButtonWasPressed(3);
            remoteControl.UndoButtonWasPressed();

            Console.ReadLine();


        }
    }
}
