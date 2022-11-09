function reverseVowels(s: string): string {
    let pos = []; let arrayS = s.split('');
    const swap = (first: number,last:number) => {
    if(arrayS[first]===arrayS[last]) return
    let temp = arrayS[first]; arrayS[first] = arrayS[last]; arrayS[last] = temp;}
    for (let i = 0; i< s.length; i++) {
    if (['a','e','i','o','u','A','E','I','O','U'].includes(s )) pos.push(i)}