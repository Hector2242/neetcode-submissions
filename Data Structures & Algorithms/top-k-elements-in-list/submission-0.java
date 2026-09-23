class Solution {
    public int[] topKFrequent(int[] nums, int k) {

        HashMap<Integer, Integer> freq = new HashMap<>();

        int[] result = new int[k];

        for(int num : nums){
            freq.put(num, freq.getOrDefault(num,0) + 1);
        }

        for(int i = 0; i < result.length; i++){

            int highestFreq = 0;
            int bestNumber = 0;
        
            for (Map.Entry<Integer, Integer> entry : freq.entrySet()) {

                int number = entry.getKey();
                int frequency = entry.getValue();

                if(frequency > highestFreq){
                    highestFreq = frequency;
                    bestNumber = number;
                }

            }

            result[i] = bestNumber;
            freq.remove(bestNumber);
        }

        return result;
    }
}
