function reverseVowels(s: string) {
    let pos:any = []; 
    let arrayS = s.split('');
    const swap = (first: number,last:number) => {
    if(arrayS[first]===arrayS[last]) return
        let temp = arrayS[first]; 
            arrayS[first] = arrayS[last]; 
            arrayS[last] = temp;}
    for (let i:number = 0; i< s.length; i++) {
        if (['a','e','i','o','u','A','E','I','O','U'].includes(s))
            pos.push(i)
}}