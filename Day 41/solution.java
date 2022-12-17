class Solution {
  private Deque<Integer> n = new ArrayDeque<>();
  private Set<String> op = Set.of("+", "-", "*", "/");
  public int evalRPN(String[] tokens) {
    for (var s: tokens) {
      if (!op.contains(s)) {
        n.addLast(Integer.parseInt(s));
      } else {
        int res = switch (s) {
          case "+" -> n.removeLast() + n.removeLast();
          case "*" -> n.removeLast() * n.removeLast();
          case "-" -> -n.removeLast() + n.removeLast();
          case "/" -> {
            double tmp = 1.0/n.removeLast() * n.removeLast();
            yield (int) (tmp > 0 ? Math.floor(tmp) : Math.ceil(tmp));
          }
          default -> throw new RuntimeException();
        };
        n.addLast(res);
      }
    }
    return n.getLast();
  }
}