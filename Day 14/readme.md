``
05/11:
Ý tưởng là dùng dfs để search từng word trong board. Ngược lại với @Violet_7 .
Để chạy nhanh hơn thì mình dùng thêm 2 cách sau:
Nếu 1 word chứa character bất kỳ k có trong board thi sẽ ignore luôn
Nếu 1 từ tồn tại trong board thì reverse của nó cũng sẽ tồn tại. Nên nếu ending char xuất hiện trong board ít hơn start char thì sẽ reverse word lại rồi search để giảm không gian tìm kiếm lại.

Có cách tối ưu hơn nữa là transfer cái board sang trie với max deep là 10, do 1 word có độ dài tối đa là 10.
Edit: Đã thử build cái board sang trie, nhưng cách này chạy chậm hơn