# Geek Brawl

**Descrição:**
Neste jogo seu personagem deve destruir o mais rápido possível os Slimes
Malignos para poder escapar para um lugar pacífico. Os Slimes nascem o tempo
todo em todo o cenário e estão tentando chegar até você para te intoxicar e assim te
derrotar.

**Mecânicas:**
1. Player:
	- Movimentação:
O personagem pode se movimentar em 8 direções, as quatro direções
cardinais e suas diagonais. As teclas utilizadas são as setas e/ou
WASD.
	- Mira e disparo:
Utilizando o mouse é possível mover a mira do personagem alterando
a direção do disparo. Para realizar um disparo basta apertar o espaço
ou o botão esquerdo do mouse.
	- Decrescimento:
Quanto mais energia negativa acumulada o Player possuir, menos
dano seus disparos irão causar. O máximo de redução de dano será
de 50%.
	- Disparo de energia positiva:
Os disparos são feitos utilizando energia positiva. Quanto mais energia
positiva o Player tiver, mais dano ele causará e mais disparos ele terá
disponíveis antes de precisar recarregar. A quantidade de disparos do
Player é redefinida no momento em que ele precisar recarregar a
arma. A quantidade máxima de disparos é 12 e pode reduzir até 4.
	- Decaimento de energia negativa:
Com o passar do tempo, a energia negativa do Player vai decaindo.

2. Slime Maligno:
	- Busca de alvo:
O inimigo procura um alvo na tela e então se desloca até ele. O alvo
deve ser reconhecido como Player.
	- Autodestruição:
Ao se chocar com o Player o inimigo causa dano ao Player e então
morre sem que o player ganhe energia.
	- Morte:
Ao ser destruído pelo Player o Slime Maligno morre e o Player ganha
uma quantidade de energia negativa.

3. Spawner:
	- Movimentação:
O Spawner anda pelas bordas do cenário
	- Criação de Slime:
A cada quantidade de tempo ele cria um novo Slime no ponto onde
estiver.

**Ambientação:**
O jogo acontece em um mapa de terra, mas cercado por árvores.
