# ssrs
Listar e Visualizar Relatorios do SqlServer Reporting Services

 ## Configuracao

Antes de utilizar é necessário configurar os parametros localizados no Web.Config. Segue abaixo a descrição de cada um deles:

* ReportingServices

Neste parâmetro deve ser configurado a url base do Reporting Services. 
        Ex: http://tubarao/ReportServer_SS2016
        Neste caso acima "tubarao" seria o nome do servidor aonde esta o Reporting Services. E "ReportServer_SS2016" o nome configurado da aplicação do Reporting Services.

* User

Opcional. Apenas necessário caso deseje configurar um usuário diferente para o SSRS. 
        Neste caso aqui você deve informar o login do usuário.
* Password

Opcional. Apenas necessário caso deseje configurar um usuário diferente para o SSRS. 
        Neste caso aqui você deve informar a senha do usuário.
* Domain

Opcional. Apenas necessário caso deseje configurar um usuário diferente para o SSRS. 
         Neste caso aqui você deve informar o dominio do usuário.

## Uso

O webform List.aspx irá listar as pastas e relatórios contidos no Reporting Services em uma treeview. Ao clicar em um relaório, o usuário sera redirecionado para o webform View.aspx aonde ele irá visualizar o relatório.

