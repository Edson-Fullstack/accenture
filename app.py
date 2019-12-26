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

# pagina prova
@myapp.route("/prova")
def prova():
    endereco = 'https://docs.google.com/document/d/e/2PACX-1vSwqYo5LKmJXVPc_yHsitMtzuYliqXGjb7oDJiKxXcamI2LpU-H0uoT4KE65-Nvu19eqpZmZNdkl43c/pub?embedded=true'
    return render_template('document.html', link=endereco)

# exe1
@myapp.route("/exe1")
def exe1():
    endereco = 'https://docs.google.com/document/d/e/2PACX-1vQiQynOeOeMrsheQTVNNXZzlhdAkBTjUCLKk04mQsDKodVIy1wnMd97CWwIge0QTcuQBVgnqLFqtfjm/pub?embedded=true'
    return render_template('document.html', link=endereco)

# exe2
@myapp.route("/exe2")
def exe2():
    endereco = 'https://docs.google.com/document/d/e/2PACX-1vSZhb6BU4bzu9YM2BUTqTGGuUW1IFrdYO3MRON2w6LVvcNYhTW12BEtbPaDZW4Nzy5kUQmmVxGtPXOM/pub?embedded=true'
    return render_template('document.html', link=endereco)

# exe3
@myapp.route("/exe3")
def exe3():
    endereco = 'https://docs.google.com/document/d/e/2PACX-1vRjombWRMYvF6qzfT02JqLUUSgW1ArNmTLrw9Hx6vrChUtHZ8VKJphcKD1wFqPJUgdp8u6qSG7Wg1mG/pub?embedded=true'
    return render_template('document.html', link=endereco)


if __name__ == "__main__":
    # rodar app no local host(host='0.0.0.0', port=80,debug=True)
    # ter apenas 1 servidor respodendo na porta 80
    myapp.run(host='0.0.0.0', port=80, debug=True)
