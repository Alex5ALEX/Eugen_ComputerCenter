using ComputerCenterClient.View;
using ComputerCenterClient.ViewClient;
using ComputerCenterClient.ViewReg;

namespace ComputerCenterClient;


internal static class Program
{
    [STAThread]
    static void Main()
    {

        ApplicationConfiguration.Initialize();


        RegistrationForm reg = new RegistrationForm();
        Application.Run(reg);


        if (reg.result == "Customer")
        {
            Application.Run(new ClientForm(reg.person));
        }
        else if (reg.result == "Admin")
        {
            Application.Run(new MainForm());
        }
    }
}