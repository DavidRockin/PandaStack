using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PandaStack
{

    class PandaStack
    {

        protected List<Module> _modules = new List<Module>();

        public void loadModules()
        {
            // TODO: Load configuration file, parse JSON, add modules to list
            Module apache = new Module("Apache", ModuleType.Service);
            apache.addConfig(new ModuleConfig("Apache2 Config", "C:/test/apache/conf/httpd.conf", ModuleConfigType.File));
            apache.addConfig(new ModuleConfig("Apache2 Extras", "C:/test/apache/conf/extra", ModuleConfigType.Directory));
            apache.setService("APACHE");

            Module mysql = new Module("MySQL", ModuleType.Service);
            mysql.addConfig(new ModuleConfig("MySQL Config", "C:/test/mysql/my.ini", ModuleConfigType.File));
            mysql.addConfig(new ModuleConfig("Apache2 Extras", "C:/test/mysql/test.ini", ModuleConfigType.File));
            mysql.addAdmin(new ModuleAdmin("MySQL Console", "C:/test/mysql/bin/mysql.exe", ModuleAdminType.Software));
            mysql.setService("MYSQL");

            this._modules.Add(apache);
            this._modules.Add(mysql);
            this._modules.Add(new Module("PHP", ModuleType.Language));
            this._modules.Add(new Module("Perl", ModuleType.Language));
            this._modules.Add(new Module("Filezilla FTP Server", ModuleType.Software));
            this._modules.Add(new Module("custom test program", ModuleType.Software));
        }

        public void reloadModules()
        {
            this._modules.Clear();
            this.loadModules();
        }

        public List<Module> getModules()
        {
            return this._modules;
        }

    }

}
