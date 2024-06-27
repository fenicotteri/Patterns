
using AdapterPattern;

INetwork network;

network = new Computer();
network.Connect220();

network = new Adapter();
network.Connect220();