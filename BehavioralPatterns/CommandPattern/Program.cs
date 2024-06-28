using CommandPattern;

Light light = new Light();

ICommand lightOn = new LightOnCommand(light);
ICommand lightOff = new LightOffCommand(light);

RemoteControl remote = new RemoteControl();

//light on
remote.SetCommand(lightOn);
remote.PressButton();
remote.PressUndo();

//light off
remote.SetCommand(lightOff);
remote.PressButton();
remote.PressUndo();