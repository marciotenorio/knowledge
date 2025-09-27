#include <bits/stdc++.h>

using namespace std;

typedef long long ll;

vector<ll> lands;
ll memo[1'000'000];
ll mh = 0;

// https://vjudge.net/contest/721550#problem/E
ll dp(ll i) {
  if (i == lands.size() - 1 || i >= lands.size()) {
    memo[i] = 0;
    return 0;
  }

  if (memo[i] != -1) {
    ++mh;
    return memo[i];
  }

  ll acc = 0;
  if (lands[i] >= lands[i + 1])
    acc = dp(i + 1) + 1;

  memo[i] = acc;
  return memo[i];
}

int main(int argc, char *argv[]) {
  ll n;
  cin >> n;

  ll in;
  for (ll i = 0; i < n; ++i) {
    cin >> in;
    lands.push_back(in);
  }

  memset(memo, -1, sizeof(memo));
  auto ans = dp(0);

  ll ret = 0;
  for (ll i = 0; i < n - 1; ++i) {
    ret = max(dp(i), dp(i + 1));
  }

  int ms = 0;
  for (int i = 0; i < n; ++i) {
    if (memo[i] > ms)
      ms = memo[i];
  }

  cout << ms << endl;
  cout << mh << endl;

  return 0;
}
