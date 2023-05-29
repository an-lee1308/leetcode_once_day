public class ParkingSystem {
    Dictionary<int, int> available = new();

    public ParkingSystem(int big, int medium, int small) {
        available.Add(1, big);
        available.Add(2, medium);
        available.Add(3, small);
    }
    
    public bool AddCar(int carType) {
        if(available[carType] > 0){
            available[carType]--;
            return true;
        }

        return false;
    }
}