import requests
import sys

encrypted_API_key = [55, 99, 54, 102, 98, 54,
                    52, 100, 99, 54, 54, 101,
                    102, 57, 98, 101, 57, 50,
                    54, 101, 51, 102, 99, 48]


key = ""

API_KEY = (chr(i) for i in encrypted_API_key)

for j in API_KEY:
    # print(j, end="")
    key = ''.join(chr(i) for i in encrypted_API_key)

API_KEY = key


# API_KEY = "7c6fb64dc66ef9be926e3fc0"


url = "https://v6.exchangerate-api.com/v6/{}/pair/{}/{}"

message = [98, 117, 32, 100, 111, 115, 121, 97,
           32, 99, 97, 108, 105, 115, 116, 105,
           114, 105, 108, 97, 109, 97, 122]

# def to_TRY(target: str) -> float:
#     response = requests.get(url.format(API_KEY, target, "TRY"))

#     data = response.json()

#     return (data["conversion_rate"])


def to_other(target: str, start: str, piece: int = 1) -> float:
    response = requests.get(url.format(API_KEY.strip(), target, start))

    data = response.json()

    return (float(data["conversion_rate"]) * int(piece))


if len(sys.argv) > 1:
    try:
        print(to_other(sys.argv[1], sys.argv[2], sys.argv[3]))
    except IndexError:
        print(to_other(sys.argv[1], sys.argv[2]))


else:
    for i in message:
        print(chr(i), end="")