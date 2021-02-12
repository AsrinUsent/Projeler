import pyshorteners

def shorten(url):
    link = pyshorteners.Shortener()
    return link.tinyurl.short(url)

if __name__ == "__main__":
    url = input("Kısaltmak istediginiz linki girin: ")
    print(f"\n{shorten(url)}")
    