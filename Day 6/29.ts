function earliestFullBloom(plantTime: number[], growTime: number[]): number {
    var growingOrder = new Array<number>();
    for(let i = 0; i < growTime.length; i++)
        {
            growingOrder.push(i);
        }
    growingOrder.sort((a, b)=>{return growTime[b] - growTime[a];});
    var result: number = 0;
    var current: number = 0;
    for(let i = 0; i < growTime.length; i++)
        {
            current += plantTime[growingOrder[i]];
            result = Math.max(result, current + growTime[growingOrder[i]]);
        }
    return result;
};
