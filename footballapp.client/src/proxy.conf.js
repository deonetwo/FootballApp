const PROXY_CONFIG = [
  {
    context: [
      "/swagger",
      "/api"
    ],
    target: "https://localhost:7002",
    secure: false
  }
]

module.exports = PROXY_CONFIG;
