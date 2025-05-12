using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class User
{
    public string FullName { get; set; }
    public string Users { get; set; }
    public string Password { get; set; }
    public static User user = new User();
}
