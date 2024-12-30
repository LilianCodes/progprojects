# doge_data
Simple Typer app created in Python that grabs data from CoinGecko Dogecoin API and optionally downloads information.


## Commands
`fetch-doge` - Grabs all current Doge market information.<br/>
`about` - Posts about section.

## Flags
``--historical`` - Checks historical data.<br/>
``--days [n]`` - Grabs information from number of days. Default is 30.<br/>
``--download`` - Downloads csv from information in command.<br/>
``--filter [type]``:<br/>
  `price`: Fetches current price,<br/>
  `market_cap`: Fetches current market cap,<br/>
  `volume`: Fetches total trading volume,<br/>
  `high`: Fetches 24h high,<br/>
  `low`: Fetches 24 low<br/>

## How To Use
Clone the repo or download via HTTPS. Run ``python main.py fetch-doge`` to see it in action. :)
