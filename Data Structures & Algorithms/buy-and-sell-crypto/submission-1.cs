public class Solution {
    public int MaxProfit(int[] prices) {
        // int buy = 0;

        // while ((buy + 1) < prices.Length && prices[buy] > prices[buy + 1]) {
        //     buy++;
        // }

        // int sell = buy;
        // while(sell < prices.Length - 1 && prices[sell] < prices[sell + 1]){
        //     sell++;
        // }

        // if (sell == buy) {
        //     return 0;
        // } else
        // {
        //     return prices[sell] - prices[buy];
        // }
        
        int minPrice = prices[0]; //minPrice is index[0] so loop starts at i =1
        int maxProfit = 0;

        for(int i = 1; i < prices.Length; i++){
            if(prices[i] <= minPrice){
                minPrice = prices[i];
            } else {
                maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
            }
        }

        return maxProfit;

    }
}
