var removeDuplicates = function(s) {
    if (s === "") return s
    let stack = [s[0]]
    const a = s.length
    for(let i=1;i<a;i++){
    if (s===stack[stack.length-1]) stack.pop()
    else stack.push(s)
    }
    return stack.join("")
    };

//
function removeDuplicates(s: string): string {
    let slow = -1;
    let fast = 0;
    const ans = s.split("");
    while(fast < ans.length && slow < ans.length)
        {
            if(slow >= 0 && ans[fast] === ans[slow])
                {
                    slow--;
                }
            else
                {
                    slow++;
                    ans[slow] = ans[fast];
                }
            fast++;
        }
    return ans.join("").substring(0, slow + 1);
};