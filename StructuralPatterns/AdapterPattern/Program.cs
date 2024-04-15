using AdapterPattern;

ElectricSocket electricSocket = new ElectricSocket();

Television television = new Television();
Fridge fridge = new Fridge();

electricSocket.GiveElectricty(television);
electricSocket.GiveElectricty(fridge);

SamsungMobile samsungMobile = new SamsungMobile();
//electricSocket.GiveElectricty(mobile); XXX

MobileElectricalDeviceAdapter adapter = new MobileElectricalDeviceAdapter(samsungMobile);
electricSocket.GiveElectricty(adapter);



