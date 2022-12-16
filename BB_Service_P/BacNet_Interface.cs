﻿
using System.IO.BACnet;
using System.IO.BACnet.Storage;

namespace BB_Service_Library
{
    public enum BacNetTypes
    {
        Client_OnlyRead,
        Client_WriteRead,
        Server
    }
    interface BacNet_Interface
    {
        void StartActivity();
        void handler_OnWritePropertyRequest(BacnetClient sender, BacnetAddress adr, byte invoke_id, BacnetObjectId object_id, BacnetPropertyValue value, BacnetMaxSegments max_segments);
        void handler_OnReadPropertyRequest(BacnetClient sender, BacnetAddress adr, byte invoke_id, BacnetObjectId object_id, BacnetPropertyReference property, BacnetMaxSegments max_segments);
        void handler_OnIam(BacnetClient sender, BacnetAddress adr, uint device_id, uint max_apdu, BacnetSegmentations segmentation, ushort vendor_id);
        void handler_OnWhoIs(BacnetClient sender, BacnetAddress adr, int low_limit, int high_limit);

    }
}
