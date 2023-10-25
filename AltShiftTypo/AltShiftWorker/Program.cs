namespace AltShiftWorker;

public class Program {

//    [DllImport("user32.dll")]
//    public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
//...
//// Register Ctrl + Shift + K as a global hotkey
//RegisterHotKey(this.Handle, 1, (uint)(Modifiers.Control | Modifiers.Shift), (uint) Keys.K);

    public static void Main(string[] args) {

        IHost host = Host.CreateDefaultBuilder(args)
            .ConfigureServices(services => {
                services.AddHostedService<Worker>();
            })
            .Build();

        host.Run();
    }
}