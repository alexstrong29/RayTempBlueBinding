# RayTempBlueBinding
Binding for the ThermaLib SDK to connect to a RayTemp bluetooth LE scanner

Add a new callback class to your main project 

public class RayTempCallbacks : Java.Lang.Object, UK.CO.Etiltd.Thermalib.ThermaLib.IClientCallbacks
    {
        //public IntPtr Handle => throw new NotImplementedException();
        public RayTempCallbacks(Context context)
        {
            AppContext = context;
        }

        public Context AppContext { get; private set; }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void OnBatteryLevelReceived(IDevice p0, int p1, long p2)
        {
            //throw new NotImplementedException();
            Toast.MakeText(AppContext, $"{p1} - Battery Level", ToastLength.Long);
        }

        public void OnDeviceAccessRequestComplete(IDevice p0, bool p1, string p2)
        {
            throw new NotImplementedException();
        }

        public void OnDeviceConnectionStateChanged(IDevice p0, DeviceConnectionState p1, long p2)
        {
            //throw new NotImplementedException();
            if (p1 == DeviceConnectionState.Disconnected)
                Toast.MakeText(AppContext, $"{p0.DeviceName} Disconnected", ToastLength.Long);
        }

        public void OnDeviceDeleted(string p0, int p1)
        {
            throw new NotImplementedException();
        }

        public void OnDeviceNotificationReceived(IDevice p0, int notificationType, byte[] payload, long timestamp)
        {
            if (notificationType == DeviceNotificationType.ButtonPressed)
            {
                var s = p0.Sensors.First();
                var str = System.Text.Encoding.Default.GetString(payload);
                Toast.MakeText(AppContext, $"Device Said: {s.Reading} (in {p0.Unit})", ToastLength.Long);
            }

        }

        public void OnDeviceReady(IDevice p0, long p1)
        {
            Toast.MakeText(AppContext, $"{p0.DeviceName} - Device Ready", ToastLength.Long);


        }

        public void OnDeviceRevokeRequestComplete(IDevice p0, bool p1, string p2)
        {
            throw new NotImplementedException();
        }

        public void OnDeviceUpdated(IDevice p0, long timestamp)
        {

        }

        public void OnMessage(IDevice p0, string p1, long p2)
        {
            throw new NotImplementedException();
        }

        public void OnNewDevice(IDevice device, long timestamp)
        {
            device.RequestConnection();
        }

        public void OnRefreshComplete(IDevice p0, bool p1, long p2)
        {
            throw new NotImplementedException();
        }

        public void OnRemoteSettingsReceived(IDevice p0)
        {
            throw new NotImplementedException();
        }

        public void OnRequestServiceComplete(int p0, bool p1, string p2, string p3)
        {
            throw new NotImplementedException();
        }

        public void OnRssiUpdated(IDevice p0, int p1)
        {
            throw new NotImplementedException();
        }

        public void OnScanComplete(int p0, int deviceCount)
        {
            //throw new NotImplementedException();
            // var c = AppContext as MainActivity;
            // Toast(c, $"{p1} Devices Detected");
            Toast.MakeText(AppContext, $"{deviceCount} Devices Detected", ToastLength.Long);
        }

        public void OnScanComplete(int p0, ThermaLib.ScanResult p1, int p2, string p3)
        {

            if (p1.Desc != "success")
                Toast.MakeText(AppContext, $"{p1.Desc} Error Detected", ToastLength.Long);

        }

        public void OnUnexpectedDeviceDisconnection(IDevice p0, string p1, ThermaLib.ClientCallbacksDeviceDisconnectionReason p2, long p3)
        {
            throw new NotImplementedException();
        }

        public void OnUnexpectedDeviceDisconnection(IDevice p0, long p1)
        {
            throw new NotImplementedException();
        }
    }
