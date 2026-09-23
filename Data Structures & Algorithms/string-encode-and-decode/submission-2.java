class Solution {

    public String encode(List<String> strs) {

        String result = ""; //Empty String
        int strsLength = 0;
        for(int i = 0; i < strs.size();i++){
            strsLength = strs.get(i).length();//length of a specific string
            result += strsLength + "_"; //the follow by
            result += strs.get(i); //gives you full string data already
        }

        return result;
    }

    public List<String> decode(String str) {

        List<String> result = new ArrayList<>();

        int i = 0;

        while(i < str.length()){
            
            // Step 1: get the number n
            int n = 0;
            while (Character.isDigit(str.charAt(i))) {
                n = n * 10 + str.charAt(i) - '0'; // use the multiply-by-10 pattern here
                i++;
            }

            // Step 2: skip the underscore '_'
            if(str.charAt(i) == '_'){
                i++; //move pointer past '_'
            }

            // Step 3: grab exactly n characters
            String grabbed = "";
            int count = 0;
            while(count < n && i < str.length()){
                grabbed += str.charAt(i);
                i++;
                count++;
            }

            result.add(grabbed);
        }

        return result;

    }
}
