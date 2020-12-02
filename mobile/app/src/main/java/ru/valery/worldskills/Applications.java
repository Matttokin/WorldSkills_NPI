package ru.valery.worldskills;

import android.app.Application;
import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;
import ru.valery.worldskills.ApiModule.ApiValue;
import ru.valery.worldskills.ApiModule.ServerApi;

public class Applications extends Application {

    private static ServerApi umoriliApi;
    private Retrofit retrofit;

    @Override
    public void onCreate() {
        super.onCreate();

        //Инициализируем библиотеку для взаимодействия с сервером
        retrofit = new Retrofit.Builder()
                .baseUrl(ApiValue.URL_API)
                .addConverterFactory(GsonConverterFactory.create())
                .build();
        umoriliApi = retrofit.create(ServerApi.class);
    }

    //По запросу возвращаем методы Api
    public static ServerApi getApi() {
        return umoriliApi;
    }
}
