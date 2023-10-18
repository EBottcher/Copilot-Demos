# Copilot-Demos : Save Image Locally - Python
## Example 1

Type #get the image from https://octodex.github.com/images/original.png and save it locally in the SaveImage.py file

Press Ctrl+Enter to view Copilot suggested solutions. Select the one you want to use.For example:

<pre>
import requests
from PIL import Image
from io import BytesIO

image_url = "https://octodex.github.com/images/original.png"

r = requests.get(image_url) # create HTTP response object

image = Image.open(BytesIO(r.content))
image.save("myimage.png")

print("Image downloaded!")
</pre>

Run the program using Python.exe and verify an new image has been saved.

## Example 2
After the last line type #convert image to grayscale

Copilot should complete it for you with something like:

<pre>
image = image.convert('L')
image.save("myimage-grayscale.png")
print("Image converted to grayscale!")
</pre>
