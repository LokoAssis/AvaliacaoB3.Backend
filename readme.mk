# AvaliacaoB3.Backend
OBS: Conforme repassado ao recrutador, sou desenvolvedor backend, e como tenho mais segurança nessa parte, foi feito somente o backend. 
Prefiro ser transparente referente a não ser especialista em frontend e com isso evitar possiveis futuros problemas.

1) Execução do projeto e teste da solução:
Ao executar a solution do backend, automaticamente será aberto uma pagina local do Swagger em seu browser, onde é possivel realizar chamadas de teste através do endpoint POST "api/calculos/cdb". 

Exemplo de JSON a ser enviado:
{
 "valorInicial": 1000,
 "prazo": 12
}

Segue imagem abaixo de exemplo:

![image](https://user-images.githubusercontent.com/45275039/206273060-7cf950b1-d0d2-493f-92c3-8e96396389dd.png)

2) Execução de testes automatizados:
Os testes automatizados estão no "AvaliacaoB3.Testes", onde foi utilizado o xUnit. Para executar-los, basta clicar com o botão direito sobre a classe "CdbTestes.cs" e ir na opção "Executar Testes", conforme imagem abaixo:

![image](https://user-images.githubusercontent.com/45275039/206274521-0d01a3ad-13a5-4be4-9a5f-0e3ac8491e0f.png)
