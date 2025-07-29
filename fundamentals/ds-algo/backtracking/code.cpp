#include <bits/stdc++.h>

using namespace std;

typedef long long ll;
int LARGE = 1'000'000'000;

vector<int> coins = {1, 3, 4};
vector<int> ans;
map<int, int> memo;

int solve(int x) {
  if (x < 0)
    return LARGE;
  if (x == 0)
    return 0;

  if (memo.find(x) != memo.end())
    return memo[x];

  int best = LARGE;
  for (auto c : coins) {
    best = min(best, solve(x - c) + 1);
  }

  memo[x] = best;
  return best;
}

int solve2(int n) {
  ans[0] = 0;

  for (int x = 1; x <= n; x++) {
    ans[x] = LARGE;

    for (auto c : coins) {
      if (x - c >= 0) {
        ans[x] = min(ans[x], ans[x - c] + 1);
      }
    }
  }
}

int main() {
  ios_base::sync_with_stdio(0);
  cin.tie(0);

  cout << solve(1000) << endl;
}
