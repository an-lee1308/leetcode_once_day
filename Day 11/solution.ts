function minMutation(start: string, end: string, bank: string[]): number {
    const queue = new ArrayDeque<string>();
    const set = new Set<string>();
    const char = ['A', 'T', 'G', 'C'];
    var ans = 0;
    queue.offer(start);
    set.add(start);
    while(!queue.isEmpty())
        {
            var nodes = queue.size();
            for(let i = 0; i < nodes; i++)
                {
                    let currentNode = queue.poll();
                    if(currentNode === end)
                        {
                            return ans;
                        }
                    for(let c of char)
                        {
                            for(let j = 0; j < currentNode.length; j++)
                                {
                                    let mutation = currentNode.substring(0, j) + c + currentNode.substring(j + 1);
                                    if(bank.includes(mutation) && !set.has(mutation))
                                        {
                                            queue.offer(mutation);
                                            set.add(mutation);
                                        }
                                }
                        }
                }
            ans++;
        }
   
    return -1;
};
class ArrayDeque<T>
    {
        private buffer;
        public constructor()
        {
            this.buffer = new Array<T>();
        }
        public offer(item: T)
        {
            this.buffer.push(item);
        }
        public peek(): T
        {
            return this.buffer[0];
        }
        public poll(): T
        {
            const tmp: T = this.buffer[0];
            this.buffer.shift();
            return tmp;
        }
        public size(): number
        {
            return this.buffer.length;
        }
        public isEmpty(): boolean
        {
            return (this.buffer.length == 0);
        }
    }