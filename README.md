![Sniff](Sniff_50px.png)<br><br>
Server application for TrakHound. Access MTConnect data using TrakHound to view processed manufacturing data from CNC equipment.

# Configuration
Configuration is read from an XML file in the following format:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<DeviceServer>
  <Devices>
    <Device deviceId="1234" deviceName="VMC-3Axis">http://agent.mtconnect.org</Device>
    <Device deviceId="456" deviceName="OKUMA.Lathe">http://74.203.109.245:5001</Device>
  </Devices>
  <DataServers>
    <DataServer url="http://api.trakhound.com" bufferPath="c:\TrakHound\Buffers\">
      <DataTypes>
        <DataType>POSITION</DataType>
        <DataType>STATUS</DataType>
        <DataType>PROGRAM</DataType>
      </DataTypes>
    </DataServer>
  </DataServers>
</DeviceServer>
```

## Device 
Represents each MTConnect Agent that the Device Server going to be reading from.

#### Device ID 
###### *(XmlAttribute : deviceId)*
The globally unique identifier for the device (usually a GUID)

#### Device Name
###### *(XmlAttribute : deviceName)*
The DeviceName of the MTConnect Device to read from

#### Address
###### *(XmlText)*
The base Url of the MTConnect Agent. Do not specify the Device Name in the url, instead specify it under the deviceName attribute.

## Data Server
Represents each TrakHound Data Server that data is sent to in order to be strored and processed.

#### Url 
###### *(XmlAttribute : url)*
The base Url of the TrakHound Data Server to send data to

#### Buffer Path
###### *(XmlAttribute : bufferPath)*
The directory where the buffer files should be stored. The Buffer is used to store data that hasn't been successfully sent yet.

