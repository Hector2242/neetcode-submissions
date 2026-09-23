public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // make three dictionaries: rows, cols, boxes
        Dictionary<int, HashSet<char>> rows = new   Dictionary<int,HashSet<char>>();
        Dictionary<int, HashSet<char>> cols = new   Dictionary<int,HashSet<char>>();
        Dictionary<int, HashSet<char>> boxes = new   Dictionary<int,HashSet<char>>();

        int boxIndex;

        // loop i from 0 to 8
            // add key i with an empty set to rows, cols, and boxes
         for(int i = 0; i < 9; i++){
            rows.Add(i, new HashSet<char>());
            cols.Add(i, new HashSet<char>());
            boxes.Add(i, new HashSet<char>());
        }

        // loop r over every row
            // loop c over every column
                // store the digit at (r, c)
                // if the digit is '.', skip to the next cell
                // compute boxIndex from r and c
                // if the digit is already in rows[r], cols[c], or boxes[boxIndex], return false
                // add the digit to rows[r], cols[c], and boxes[boxIndex]

        // no duplicates found anywhere, return true
        for(int r = 0; r < board.Length; r++){
            for(int c = 0; c < board[r].Length; c++){

                if((board[r][c] == '.')){
                    continue;
                }
                
                boxIndex = (r/3) * 3 + (c/3);

                if((rows[r].Contains(board[r][c])) || (cols[c].Contains(board[r][c])) || (boxes[boxIndex].Contains(board[r][c]))){
                    return false;
                }

                rows[r].Add(board[r][c]);
                cols[c].Add(board[r][c]);
                boxes[boxIndex].Add(board[r][c]);
            }
        }

        return true;

    }
}