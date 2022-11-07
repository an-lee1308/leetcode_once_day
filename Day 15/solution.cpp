class Solution {
public:
    int maximum69Number (int num) {
        int n = 1000;
        while(n){
            if((num / n) % 10 == 6)
                return num + 3 * n;
            n /= 10;
        }
        return num;
    }
};