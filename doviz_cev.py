import requests
import json

apiUrl = 'https://api.exchangeratesapi.io/latest?base='

bozulacakPara = input('Bozulan Doviz Türü: ')
alinanPara = input('Alinacak Doviz Türü: ')
miktar = int(input(f'Ne Kadar {bozulacakPara} Bozdurmak İstiyorsunuz: '))

bozulacakPara = bozulacakPara.upper()
alinanPara = alinanPara.upper()

bilgi = requests.get(apiUrl + bozulacakPara)
bilgi = json.loads(bilgi.text)

print(f'1 {bozulacakPara} = {bilgi["rates"][alinanPara]}{alinanPara}')
print(f'{miktar} {bozulacakPara}: {miktar * bilgi["rates"][alinanPara]} {alinanPara}')
