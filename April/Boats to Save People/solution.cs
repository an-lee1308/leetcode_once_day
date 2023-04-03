public class Solution {
    public int NumRescueBoats(int[] people, int limit) {
        Array.Sort(people);//Sorting the people Array
        int boats=0;
        int pointIndex =0;
        int n = people.Length;
        for(int i=0;i<n;i++)//First We are trying to find the point where the person has to travel individually to shorten the array
        {
            if(people[i]>=limit)
            {
                boats = n-i;//adding all individual people to travel by individual boats
                pointIndex=i;
                break;//we dont need further traversal
            }
        }
        int j=0;
        int k=pointIndex==0?n-1:pointIndex-1;
        while(j<=k)//Using two pointer to find the persons who matches the limit or lower than the limit
        {
            if(people[j]+people[k]>limit)//if they are greater than the limit we are sending kth person alone
            {
                boats++;
            }
            else
            {
                boats++;//we are sending this as pair
                j++;
            }
            k--;
        }
        return boats;
    }
}