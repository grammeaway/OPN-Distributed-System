FROM nginx
COPY ./www /usr/share/nginx/html
COPY nginx.conf /etc/nginx/nginx.conf
COPY ./mycert/mydomain.crt /etc/nginx/ssl/
COPY ./mycert/mydomain.key /etc/nginx/ssl/
