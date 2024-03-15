import requests, sys, os, time

while True:
    try:
        print("""Hello and welcome to the Etsy Shop Finder.\n
              This program will take any text input and match it to a Shop.\n
              If the page/shop exists, the program will tell you.\n
              If not, it's easily assumed that the page/shop doesn't exist. :)\n\n
              """)
        etsy_req = input("Shop Name (or Exit): ")
        r = requests.get('https://etsy.com/shop/' + etsy_req)

        if r.status_code == 200:
            print('The shop exists. :(')
            print('Search will restart in 5 seconds...')
            time.sleep(5)
            os.system('cls')
        else:
            print('The shop does not exist! :)')
            print('Or it actually might. Here\'s some information: ')
            print('Status Code: ', r.status_code)
            print('URL: ', r.url)
            print('Search will restart in 10 seconds...')
            time.sleep(10)
            os.system('cls')

    except:
        print('\n\nSee you later!')
        sys.exit(0)