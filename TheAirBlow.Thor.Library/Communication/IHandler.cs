namespace TheAirBlow.Thor.Library.Communication; 

public interface IHandler {
    public string GetNotes();
    public Task<List<DeviceInfo>> GetDevices();
    public void Initialize(string id);
    public bool IsConnected();
    public void Disconnect();
    public void BulkWrite(byte[] buf, int timeout = 5000, bool zlp = false);
    public byte[] BulkRead(int amount, out int read, int timeout = 5000);
    public void SendZLP();
    public void ReadZLP();
}