using System;

namespace TicTacToe
{
    public class PlayControler
    {
        public void Player()
        {
            GameSystem gameSystem = new GameSystem();
            int[] thuTu = new int[0];
            char[] boardMau = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int point;
            int player = 1;
            try
            {
                while (true)
                {
                    gameSystem.CheckWin();
                    while (true)
                    {
                        Console.WriteLine();
                        if (player % 2 == 0)
                        {
                            Console.Write("{0} chọn điểm đánh: ", GameSystem.playerName2);
                        }
                        else
                        {
                            Console.Write("{0} chọn điểm đánh: ", GameSystem.playerName1);
                        }
                        if (int.TryParse(Console.ReadLine(), out point) && point > 0 && point <= 9)
                        {
                            //Tăng kích thước mảng và gán point vào phần tử cuối cùng của mảng
                            Array.Resize(ref thuTu, thuTu.Length + 1);
                            thuTu[thuTu.Length - 1] = point;
                            break;
                        }
                    }
                    if (gameSystem.board[point - 1] != 'X' && gameSystem.board[point - 1] != 'O')
                    {
                        if (player % 2 == 0)
                        {
                            //Giữ chiều dài mang ở 6 và xoá phần tử đầu tiên
                            if (thuTu.Length >= 7)
                            {
                                gameSystem.board[thuTu[0] - 1] = boardMau[thuTu[0] - 1];
                                thuTu = thuTu.Skip(1).ToArray();
                            }
                            gameSystem.board[point - 1] = 'O';
                            player++;
                        }
                        else
                        {
                            if (thuTu.Length >= 7)
                            {
                                gameSystem.board[thuTu[0] - 1] = boardMau[thuTu[0] - 1];
                                thuTu = thuTu.Skip(1).ToArray();
                            }
                            gameSystem.board[point - 1] = 'X';
                            player++;
                        }
                        gameSystem.Display();
                    }
                    else
                    {
                        Console.WriteLine("Điểm này đã đánh rồi, mời đánh vị trí khác");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi tại Player(): " + ex);
            }
        }

    }
}