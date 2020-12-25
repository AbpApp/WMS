rem openresty  负载
D:\Tools\nssm\nssm.exe install Hd_Nginx D:\Tools\openresty\nginx.exe
D:\Tools\nssm\nssm.exe set Hd_Nginx AppDirectory D:\Tools\openresty\
D:\Tools\nssm\nssm.exe set Hd_Nginx AppStdout D:\Tools\openresty\nssm.log
D:\Tools\nssm\nssm.exe set Hd_Nginx AppStderr D:\Tools\openresty\nssm.log
D:\Tools\nssm\nssm.exe start Hd_Nginx
D:\Tools\nssm\nssm.exe restart Hd_Nginx

rem 容器服务
D:\Tools\nssm\nssm.exe install Hd_Container "C:\Program Files\dotnet\dotnet.exe"
D:\Tools\nssm\nssm.exe set Hd_Container AppParameters Hd.Container.HttpApi.Host.dll --port 21030
D:\Tools\nssm\nssm.exe set Hd_Container AppDirectory D:\wwwroot\Hd.Container.HttpApi.Host\
D:\Tools\nssm\nssm.exe set Hd_Container AppStdout D:\wwwroot\Hd.Container.HttpApi.Host\Logs\nssm.log
D:\Tools\nssm\nssm.exe set Hd_Container AppStderr D:\wwwroot\Hd.Container.HttpApi.Host\Logs\nssm.log
D:\Tools\nssm\nssm.exe start Hd_Container
D:\Tools\nssm\nssm.exe restart Hd_Container
