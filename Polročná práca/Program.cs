using Polročná_práca;
using System.Security.Cryptography.X509Certificates;

Player player = new Player();
Monster monster = new Monster(100,5);
engine engine = new engine();

engine.Play(player, monster);
