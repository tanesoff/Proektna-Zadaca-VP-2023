# tic-tac-toe
Х-Точка е игра каде што двајца играчи наизменични кликнуваат на матрица со димензии 3х3. При притиснување на едно од квадрачињата се обележува со Х(Зелена боја) или О(Цревена боја). 

#Правила
За еден играч да победи на Х-точка морат да спојт три Иксој или Точки по ред хоризонтано, вертикално или дијагонално со ист знак, покажано како на сликата долу.
![alt text](https://github.com/tanesoff/Proektna-Zadaca-VP-2023/blob/master/Sliki/One.png)
![alt text](https://github.com/tanesoff/Proektna-Zadaca-VP-2023/blob/master/Sliki/Two.png)

Ако некој играч победи се појаува MessageBox каде прикажува името на играчот со победи и се додава поен на тој играч. Доколку сите полинја се пополнети без никој играч да спој Икојс или Точки не се број поени и морат да се ресетират играта. 

#Дизајн
-Во Design делот има 9 дугминја за играта
-Едно Дугме за ресетирање
-И лабели за player1 i player 2

#Имплемнтација
Играва се сотои од две класи Check.cs и другата е од самата форма класата.
-Make() функцијата се сотој од еден for loop за ресетирање на дугмињата во првобитната состојба. Во From1.cs секое дугме имат еден if каде што се проверува кој е на ред да игра преку променливата "turn" каде сто ако е парен бројот Х е на ред а во спротива е О на ред.
После секој клик се зголемува turn. При притиснување влегува во if каде што се менува бојата на дугмето, се додава текст(X или О), се менува низата game_board на позиција "turn" во Х или О,
после тоа се проверува дали некој има победено со помош на класата Check.cs каде што има енда функција is_winner() што ги има сите можни комбинации на играва и ако во случај е победа се зголемува поени на играчот и се прикажува MessageBox. 

``` 
if (this.turn % 2 == 0)
            {
                btn1.BackColor = Color.Green;
                btn1.Text = "X";
                btn1.Enabled = false;
                this.game_board[0] = 'x';

                this.get_win = this.cw.is_winner(this.game_board, turn);
                if (this.get_win == 'x')
                {
                    MessageBox.Show("x wins!");

                    this.dump = lb_pls1.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls1.Text = dumpi.ToString();
                    this.make();
                }
            }
            else
            {
                btn1.BackColor = Color.Red;
                btn1.Text = "O";
                btn1.Enabled = false;
                this.game_board[0] = 'o';

                this.get_win = this.cw.is_winner(this.game_board, turn);
                if (this.get_win == 'o')
                {
                    MessageBox.Show("o wins!");
                    this.dump = lb_pls2.Text;
                    this.dumpi = int.Parse(this.dump);
                    dumpi++;
                    lb_pls2.Text = dumpi.ToString();
                    this.make();
                }
            }

            this.turn++;
```
