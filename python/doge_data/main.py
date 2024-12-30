import requests
import typer
import csv
from rich.table import Table
from rich.console import Console
from datetime import datetime

doge_app = typer.Typer()
doge_console = Console()

DOGE_API_URL = "https://api.coingecko.com/api/v3/coins/dogecoin"
HISTORIC_API_URL = "https://api.coingecko.com/api/v3/coins/dogecoin/market_chart?vs_currency=usd&days=30"


@doge_app.command()
def fetch_doge(
    filter: str = typer.Option(
        None,
        help="Specify data to display. 'price', 'market_cap', 'volume', 'high', 'low'",
    ),
    download: bool = typer.Option(False, help="Download as CSV."),
    historical: bool = typer.Option(False, help="Fetch and download historical data."),
    days: int = typer.Option(30, help="Number of days to fetch. (default is 30)"),
):
    try:
        if historical:
            fetch_historical_data(days, download)
            return

        doge_console.print("Blasting off to the moon!", style="bold")

        res = requests.get(DOGE_API_URL, headers={"User-Agent": "DogeCLI/1.0"})
        res.raise_for_status()
        data = res.json()

        name = data["name"]
        symbol = data["symbol"].upper()
        price = data["market_data"]["current_price"]["usd"]
        market_cap = data["market_data"]["market_cap"]["usd"]
        total_vol = data["market_data"]["total_volume"]["usd"]
        high_24h = data["market_data"]["high_24h"]["usd"]
        low_24h = data["market_data"]["low_24h"]["usd"]

        doge_table = Table(
            title="Dogecoin Market Data (USD)", title_style="bold yellow"
        )
        doge_table.add_column("Metric", justify="left")
        doge_table.add_column("Value", justify="right")

        filters = [f.strip() for f in (filter or "all").split(",")]
        data_to_display = []

        if "all" in filters or "name" in filters:
            data_to_display.append(("Name", name))
        if "all" in filters or "symbol" in filters:
            data_to_display.append(("Symbol", symbol))
        if "all" in filters or "volume" in filters:
            data_to_display.append(("Total Volume", f"${total_vol:,.2f}"))
        if "all" in filters or "price" in filters:
            data_to_display.append(("Current Price", f"${price:,.2f}"))
        if "all" in filters or "market_cap" in filters:
            data_to_display.append(("Market Cap", f"${market_cap:,.2f}"))
        if "all" in filters or "high" in filters:
            data_to_display.append(("24h High", f"${high_24h:,.2f}"))
        if "all" in filters or "low" in filters:
            data_to_display.append(("24h Low", f"${low_24h:,.2f}"))

        for row in data_to_display:
            doge_table.add_row(row[0], row[1])

        doge_console.print(doge_table)

        if download:
            download_data(data_to_display)
    except requests.exceptions.RequestException as e:
        doge_console.print(f"Error fetching data: {e}")


def fetch_historical_data(days: int, download: bool):
    try:
        doge_console.print(f"Blasting off to get information on the last {days} days!")
        params = {"vs_currency": "usd", "days": days}
        res = requests.get(
            HISTORIC_API_URL, params=params, headers={"User-Agent": "DogeCLI/1.0"}
        )
        res.raise_for_status()

        historical_data = res.json()
        prices = historical_data.get("prices", [])

        historical_to_display = [("Date", "Price")]
        for price_data in prices:
            timestamp = datetime.fromtimestamp(price_data[0] / 1000).strftime(
                "%y-%m-%d %H:%M:%S"
            )
            price = price_data[1]
            historical_to_display.append((timestamp, f"${price:,.2f}"))

        if download:
            download_historical_data(historical_to_display, days)

        his_table = Table(title=f"Historical Data - Past {days} Days")
        his_table.add_column("Date", justify="left")
        his_table.add_column("Price", justify="right")

        for row in historical_to_display[1:]:
            his_table.add_row(row[0], row[1])

        doge_console.print(his_table)
    except requests.exceptions.RequestException as e:
        doge_console.print(f"Error fetching the data: {e}")


def download_historical_data(data, days):
    try:
        f = f"dogecoin_market_data_{days}_days.csv"
        with open(f, mode="w", newline="") as file:
            writer = csv.writer(file)
            writer.writerow(["Metric", "Value"])
            for row in data:
                writer.writerow(data)

        doge_console.print(f"Data has been saved!", style="bold yellow")
    except Exception as e:
        doge_console.print(f"Error saving data to CSV: {e}")


def download_data(data):
    try:
        f = "doge_market_data.csv"
        with open(f, mode="w", newline="") as file:
            writer = csv.writer(file)
            writer.writerow(["Metric", "Value"])
            for row in data:
                writer.writerow(row)

        doge_console.print(f"Data has been saved!", style="bold yellow")
    except Exception as e:
        doge_console.print(f"Error saving data to CSV: {e}", style="bold red")


@doge_app.command()
def about():
    doge_console.print("Hello there! :)", style="bold yellow")
    doge_console.print(
        "Created for u/TardigradeLove & others that will find it useful. <3"
    )
    doge_console.print(
        "If you'd like to donate to this project\n"
        "My Doge address is as follows:\n"
        "DApFtNUkEn5sSe3MbWD9TvffGCwWcLQUfd"
    )


if __name__ == "__main__":
    doge_app()
