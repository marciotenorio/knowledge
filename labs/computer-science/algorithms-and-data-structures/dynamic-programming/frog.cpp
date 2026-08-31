#include <bits/stdc++.h>

using namespace std;

int cache[1000000];

int dp(int i, int n, vector<int> ar) {
  if (i == n)
    return 0;

  if (cache[i] != -1)
    return cache[i];

  int c = abs(ar[i] - ar[i + 1]) + dp(i + 1, n, ar);
  if (i + 2 <= n)
    c = min(c, abs(ar[i] - ar[i + 2]) + dp(i + 2, n, ar));

  return cache[i] = c;
}

int main(int argc, char *argv[]) {
  ios_base::sync_with_stdio(false);
  cin.tie(0);

  // 10 30 40 20
  int n;
  cin >> n;

  vector<int> ar(n);
  for (int i = 0; i < n; ++i) {
    cin >> ar[i];
  }
  memset(cache, -1, sizeof(cache));
  cout << dp(0, n - 1, ar) << endl;

  return 0;
}
