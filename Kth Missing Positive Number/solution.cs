public class Solution 
{
    public int FindKthPositive(int[] arr, int k)
    {
        var left = 0;
        var right = arr.Length - 1;

        while (left <= right)
        {
            var mid = left + (right - left) / 2;

            if (arr[mid] - mid - 1 < k)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        return left + k;
    }
}

\*
Đây là một giải thuật để tìm số nguyên dương bị thiếu thứ K trong một dãy tăng dần các số nguyên dương. Giải thuật này sử dụng kỹ thuật tìm kiếm nhị phân (binary search) để tìm vị trí của số bị thiếu trong mảng.

Cách thức hoạt động của giải thuật:

Khởi tạo hai biến left và right, lần lượt là chỉ số đầu và cuối của mảng arr.
Trong khi left không vượt quá right, thực hiện các bước sau:
Tính toán chỉ số trung tâm mid của đoạn mảng từ left đến right.
Tính toán số lượng các số bị thiếu từ số đầu tiên trong mảng đến vị trí mid bằng cách lấy hiệu của giá trị phần tử ở vị trí mid trong mảng với vị trí mid và trừ đi 1.
So sánh số lượng các số bị thiếu với giá trị k. Nếu số lượng các số bị thiếu nhỏ hơn k, ta cần tiếp tục tìm kiếm phía bên phải của vị trí mid, do đó cập nhật left = mid + 1. Ngược lại, ta cần tiếp tục tìm kiếm phía bên trái của vị trí mid, do đó cập nhật right = mid - 1.
Khi kết thúc vòng lặp, chỉ số left sẽ trỏ đến vị trí của số bị thiếu trong mảng arr. Để tìm giá trị của số bị thiếu, ta cộng left với k và trả về kết quả.
Ví dụ, nếu đầu vào là arr = [2, 3, 4, 7, 11] và k = 5, giá trị trả về của hàm sẽ là 9, vì số 9 là số bị thiếu thứ 5 trong dãy số nguyên dương tăng dần từ 1 đến vô cùng, mà không xuất hiện trong mảng arr.
 */