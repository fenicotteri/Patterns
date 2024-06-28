using CommandPattern;

Pult pult = new Pult();
TV tv = new TV();

pult.SetCommand(new TVOnCommand(tv));
pult.PressButton();
pult.PressUndo();

Microwave microwave = new Microwave();
pult.SetCommand(new MicrowaveCommand(microwave, 5000));
pult.PressButton();