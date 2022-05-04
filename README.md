# Busca-Binaria
##Introdução
Olá! Este programa trata-se de um algoritmo de Busca Binária, na qual é feita uma pesquisa em uma lista de números na ordem crescente para localizar o número que deseja localizar. O programa a seguir foi feito no SharpDevelop utilizando o Windows Application.
&nbsp;

##Funcionalidade do Programa
O programa ele busca o número digitado na TextBox em uma lista com 100 números em ordem crescente. Para isso, ao clicar no botão de Procurar, o programa fará o cálculo para saber qual número está no meio da lista, fazendo a seguinte conta:
<center> m = (p + n)/2 </center>
Sendo:
m = posição do número do meio da lista;
p = posição do primeiro número da lista (inicialmente 0);
n = posição do último número da lista (variando de acordo com o tamanho dela).
Após isso, será feito uma análise se o número da posição **m**, havendo as seguintes três possibilidades:
<ol>
  <li>**Se o número da posição _m_ for igual ao valor do número digitado pelo usuário,** será retornado a posição **m** na tela;</li>
  <li>**Se o número da posição _m_ for maior que o valor do número digitado pelo usuário,** a variável **n** receberá _m - 1_;</li>
  <li>**Se o número da posição _m_ for menor que o valor do número digitado pelo usuário,** a variável **p** receberá _m + 1_.</li>
</ol>
O cálculo será repetido diversas vezes até que o valor da posição **m** seja igual ao valor digitado pelo usuário. Caso não seja encontrado, será informado que o número não foi encontrado na lista
&nbsp;

##Atenção!
<ol>
  <li>Evite de clicar no botão com a TextBox sem texto;</li>
  <li>O programa só permite o uso de números **inteiros**, isto é, números negativos e positivos;</li>
  <li>Caso queira mudar os números da lista, apenas altere o texto dentro do arquivo txt "numeros", localizado na pasta *Bin\Debug*.</li>
</ol>

Este é o meu programa, espero que tenha gostado e que a explicação tenha sido eficiente. No próprio código, há alguns comentários explicando as linhas para caso queira entender melhor.
