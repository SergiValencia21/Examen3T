from PIL import Image
import os
# Cargamos la imagen
imagen = Image.open("jv.jpg")

# Convertimos la imagen a blanco y negro
umbral = 128 # Valor umbral
blanco = (255, 255, 255) # Color blanco
negro = (0, 0, 0) # Color negro

for x in range(imagen.width):
    for y in range(imagen.height):
        # Obtenemos el valor del pixel
        pixel = imagen.getpixel((x, y))
        
        # Calculamos el valor promedio de los componentes RGB
        promedio = sum(pixel) // 3
        
        # Asignamos el color blanco o negro en función del valor umbral
        if promedio >= umbral:
            imagen.putpixel((x, y), blanco)
        else:
            imagen.putpixel((x, y), negro)

# Guardamos la imagen en blanco y negro
imagen.save("jv_bn.jpg")


