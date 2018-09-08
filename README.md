# APIIndicadores
Crie sua primeira API REST em Linux com o ASP.NET Core 2.1 e o SQL 2017 do Coding Night
https://www.youtube.com/watch?v=FClii4GC6sI

# Requisitos
* SqlServer 2017 Linux -> https://www.microsoft.com/pt-br/sql-server/sql-server-downloads

* Sql Operations Studio -> https://docs.microsoft.com/pt-br/sql/sql-operations-studio/download?view=sql-server-2017

* .NET Core -> https://www.microsoft.com/net/download

* Visual Studio Code -> https://code.visualstudio.com/download

* Dapper -> https://github.com/StackExchange/Dapper

# Meu ambiente
### Xubuntu 18.04
#### Instalando Docker
* sudo apt install apt-transport-https ca-certificates curl software-properties-common

* curl -fsSL https://download.docker.com/linux/ubuntu/gpg | sudo apt-key add -

* sudo add-apt-repository "deb [arch=amd64] https://download.docker.com/linux/ubuntu bionic stable"

* sudo apt update && sudo apt install docker-ce

* sudo usermod -aG docker ${USER}
#### Rodando MS SQL Server 2017 via docker
* docker run --name sqlserver2017 -e 'ACCEPT_EULA=Y' -e 'SA_PASSWORD=SqlServer2017!' -p 1433:1433 -v ~/SQLServer2017:/var/opt/mssql -d microsoft/mssql-server-linux:2017-latest

#### Instalando o Sql Operations Studio
* wget -O sqlOpsStudio.deb  https://go.microsoft.com/fwlink/?linkid=2013833

* sudo dpkg -i sqlOpsStudio.deb

#### Instalando o Visual Studio Code
* wget -O vscode.deb https://go.microsoft.com/fwlink/?LinkID=760868

* sudo dpkg -i vscode.deb

#### Instalando o .Net Core
* wget -q https://packages.microsoft.com/config/ubuntu/18.04/packages-microsoft-prod.deb

* sudo dpkg -i packages-microsoft-prod.deb

* sudo apt update && sudo apt install dotnet-sdk-2.1
