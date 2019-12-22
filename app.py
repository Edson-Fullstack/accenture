"""
PEP 8 -- Style Guide for Python Resume
pip8 app
"""
from flask import Flask, render_template, url_for, request

TEST_CONTROL = 0


def tests(controle, mensagem):
    """mensagem a ser exibida no durante testes"""
    if(TEST_CONTROL >= controle):
        print(str(mensagem))


myapp = Flask(__name__)


# home page
@myapp.route("/")
def index():
    return render_template('index.html')

# home page
@myapp.route("/prova")
def prova():
    return render_template('prova.html')

# home page
@myapp.route("/manual")
def manual():
    return render_template('prova.html')


if __name__ == "__main__":
    # rodar app no local host(host='0.0.0.0', port=80,debug=True)
    # ter apenas 1 servidor respodendo na porta 80
    myapp.run(host='0.0.0.0', port=80, debug=True)
