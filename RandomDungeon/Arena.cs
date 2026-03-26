using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

namespace RandomDungeon
{
    public class Arena
    {
        private List<Enemy> enemies;

        public Arena(List<Enemy> enemies)
        {
            this.enemies = enemies;
        }

        public List<Enemy> GetEnemies()
        {
            return enemies;
        }

        public void SetEnemies(List<Enemy> value)
        {
            enemies = value;
        }

        public void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }

        public void RemoveEnemy(Enemy enemy)
        {
            enemies.Remove(enemy);
        }

        // Método Para Mostrar Todos os Inimigos Atuais
        // Exemplo: "Arena: Troll, Skeleton, Ogre"
        public void ShowEnemies()
        {
            // CÓDIGO AQUI

            string Total = "Arena :";

            foreach (var item in enemies)
            {
                
                Total += string.Join(Convert.ToString(item));
                Total += ", ";
            } 

            Total = Total.Remove(Total.Length - 2);
            
        }
        
        // Simula uma Batalha Entre Dois Inimigos
        public void Battle(Enemy attacker, Enemy defender)
        {
            // Subtrai o Ataque do Atacante à Vida do Defensor
            // Garante que a Vida Não Fique Negativa
            // CÓDIGO AQUI 

            int DefenderHealth = attacker.GetAttack() - defender.GetHealth();
            if (DefenderHealth < 0)
            {
                DefenderHealth = 0;
            }

            // Se a Vida do Defensor Chegar a 0, Remove-o da Arena
            // CÓDIGO AQUI

            if (DefenderHealth == 0)
            {
                Arena.RemoveEnemy(defender);
            }
        }
    }
}  