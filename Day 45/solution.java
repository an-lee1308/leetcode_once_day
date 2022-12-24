public int numTilings(int n) {
	return numTilingsForFinalStateOf(n, 2);
}
Map<String, Integer> memo = new HashMap<>();
public int numTilingsForFinalStateOf(int n, int colState) {
	int mod = 1_000_000_007;
	if (n < 0) return 0;

	if (n == 0) {
		if (colState == 2) { // goal achieved
			return 1;
		} else {
			return 0;
		}
	}
	String memKey = n+"|"+colState;
	if (memo.containsKey(memKey)) return memo.get(memKey);

	long ways = 0;
	if (colState == 0) { // attempting to generate tilings for ▉▉▀ means summing...
		ways += numTilingsForFinalStateOf(n-2, 2);// ▉
		ways += numTilingsForFinalStateOf(n-1, 1);// ▉▃
	} else if (colState == 1) { // attempting to generate tilings for ▉▉▃ means summing...
		ways += numTilingsForFinalStateOf(n-2, 2);// ▉
		ways += numTilingsForFinalStateOf(n-1, 0);// ▉▀
	} else if (colState == 2) { // attempting to generate tilings for ▉▉▉ means summing...
		ways += numTilingsForFinalStateOf(n-1, 0);// ▉▀
		ways += numTilingsForFinalStateOf(n-1, 1);// ▉▃
		ways += numTilingsForFinalStateOf(n-1, 2);// ▉▉
		ways += numTilingsForFinalStateOf(n-2, 2);// ▉
	}

	ways = Math.floorMod(ways, mod);
	memo.put(memKey, (int) ways);
	return (int) ways;
}