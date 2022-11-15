def count_nodes(root)
  return 0 if root.nil?
  left_length = length_tree(root.left, 'left')
  right_length = length_tree(root.right, 'right')
 
  return (2**left_length - 1) if left_length == right_length
  count_nodes(root.left) + count_nodes(root.right) + 1
end

def length_tree node, side
  return 1 if node.nil?
  side == 'left' ? length_tree(node.left, 'left') + 1 : length_tree(node.right, 'right') + 1
end