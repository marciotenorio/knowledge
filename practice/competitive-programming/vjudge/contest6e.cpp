#include <bits/stdc++.h>

using namespace std;

int dp(int i, int ac) {}

int main(int argc, char *argv[]) {
  int n;
  cin >> n;

  int in;
  for (int i = 0; i < n; ++i) {
    cin >> in;
    coins.push_back(in);
  }

  memset(memo, -1, sizeof(memo));

  for (int i = 0; i < n; i++) {
    dp(i, 0);
  }

  cout << uni.size() << endl;
  for (auto i : uni) {
    cout << i << " ";
  }
  cout << endl;

  return 0;
}
